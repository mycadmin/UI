namespace MYC.UI.DTO
{
    public struct ProjectDTO
    {
        //공통 속성 List
        public string FROM_DT;
        public string TO_DT;
        public string UPT_USER_ID;

        //프로젝트 속성 List
        public string PROJECT_ID;
        public string PROJECT_NAME;
        public string VENDOR_LIST;
        public string STATUS;
        public string CREATE_TIME;
        public string COMP_CD;
        public string USER_ID;

        //History 속성 List
        public string WORK_ID;
        public string WORK_DT;
        public string USER_LIST;
        public string WORK_DESC;
        public string LINK_CODE;

        //Action Item 속성 List
        public string ACTION_NO;
        public string ACTION_TYPE;
        public string RANK;
        public string SUBJECT;
        public string MANAGER_COMP_CODE;
        public string START_DT;
        public string END_DT;
        public string CLOSE;

        //기타 속성 List
        public string MODEL_ID;
        public string SEQ_NO;
        public string VERSION;
        public string DEL_YN;
        public string REG_ID;
    }
}
