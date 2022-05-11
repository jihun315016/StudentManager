using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class EmployeeService
    {
        /// <summary>
        /// 재직 또는 퇴사한 직원 정보 조회
        /// </summary>
        /// <param name="isResignation">퇴사 여부</param>
        /// <returns></returns>
        public DataTable GetAllEmployeeInfo(bool isResignation)
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetAllEmployeeInfo(isResignation);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 직원 정보 조회
        /// "직원 번호 - 이름" 형태로 조회한다.
        /// </summary>
        /// <param name="isOnlyTeacher">원장, 강사 직급만 조회할지, 모든 직원을 조회할지 선택</param>
        /// <returns></returns>
        public DataTable GetAllEmpNoName(bool isOnlyTeacher = false)
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetAllEmpNoName(isOnlyTeacher);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 특정 직원에 대한 정보 조회
        /// </summary>
        /// <param name="empNo">가져올 직원 번호</param>
        /// <returns></returns>
        public EmployeeVO GetEmpInfoByPk(int empNo)
        {
            EmployeeDAC dac = new EmployeeDAC();
            EmployeeVO emploeyeeVO = dac.GetEmployeeInfoByPk(empNo);
            dac.Dispose();
            return emploeyeeVO;
        }

        /// <summary>
        /// 직원 직급 리스트 조회
        /// 등록, 수정 시 콤보 박스에서 사용
        /// </summary>
        /// <returns></returns>
        public List<string> GetPosition()
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetPosition();
            List<string> list = new List<string>();

            foreach (DataRow dr in dt.Rows)
                list.Add(dr["POSITION"].ToString());

            return list;
        }

        /// <summary>
        /// 직원 등록 처리
        /// </summary>
        /// <param name="empVO">등록할 직원 정보</param>
        /// <returns></returns>
        public bool InsertEmployee(EmployeeVO empVO)            
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.InsertEmployee(empVO);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// 직원 정보 수정 처리
        /// </summary>
        /// <param name="empVO">변경할 직원 정보</param>
        /// <param name="imagePath">이미지 URL, 이미지가 없다면 null</param>
        /// <returns></returns>
        public bool UpdateEmployeeInfo(EmployeeVO empVO, string imagePath)
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEmployeeInfo(empVO, imagePath);            
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// 비밀번호 변경 처리
        /// </summary>
        /// <param name="empNo">변경할 직원 번호</param>
        /// <param name="newPassword">변경할 비밀번호</param>
        /// <returns></returns>
        public bool UpdateEmployeePassword(int empNo, string newPassword)
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEmployeePassword(empNo, newPassword);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// 직원 퇴사 또는 재입사 처리(퇴사 또는 입사 날짜 수정)
        /// </summary>
        /// <param name="empVO"></param>
        /// <param name="isResignation"></param>
        /// <returns></returns>
        public bool UpdateEndDate(EmployeeVO empVO, bool isResignation)
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEndDate(empVO, isResignation);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 직원 리스트에서 직원 이름을 통해 검색한다.
        /// </summary>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="empName">검색된 직원 이름 키워드</param>
        /// <returns></returns>
        public DataTable SearchByEmpName(DataTable dt, string empName)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"EMP_NAME LIKE '%{empName}%'";
            return dv.ToTable();
        }

        /// <summary>
        /// 직원 리스트에서 입사 또는 퇴사 날짜를 통해 검색한다.
        /// </summary>
        /// <param name="start">검색할 날짜 범위 시작 지점</param>
        /// <param name="end">검색할 날짜 범위 끝 지점</param>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="isResignations">퇴사 여부</param>
        /// <returns></returns>
        public DataTable SearchDateInList(DateTime start, DateTime end, DataTable dt, bool isResignations)
        {
            DataView dv = new DataView(dt);

            if (isResignations)            
                dv.RowFilter = $"END_DATE >= #{start.ToString("yyyy/MM/dd")}# and END_DATE <= #{end.ToString("yyyy/MM/dd")}#";
            else            
                dv.RowFilter = $"START_DATE >= #{start.ToString("yyyy/MM/dd")}# and START_DATE <= #{end.ToString("yyyy/MM/dd")}#";

            return dv.ToTable();
        }        
    }
}
