namespace MYC.UI.DTO
{
    public struct MachineDTO
    {
        //공통 속성 List
        public string FROM_DT;
        public string TO_DT;
        public string UPDATE_DT;
        public string LINK_CODE;
        public string COMP_CD;
        public string CST_USER_ID;
        public string COMP_USER_ID;
        public string USER_ID;
        public string DESC;

        //제품 속성 List
        public string MODEL_ID;
        public string MODEL_CD;
        public string MODEL_NM;
        public string MODEL_TYPE;
        public string PRODUCT_TYPE;
        public string SPEC_W;
        public string SPEC_D;
        public string SPEC_H;
        public string VENDOR_CD;
        public string MATERIAL_CD;
        public string PLAN_CD;
        public string ESTIMATE_CD;

        public string SITE_NM;
        public string PRD_NM;
        public string STAT_CD;
        public string PRODUCT_ID;
        public string MGR_CD;
        public string VER_CD;
        public string PROC_COMP_CD;
        public string PROD_COMP_CD;
        public string PROC_EQP_ID;
        public string PROD_MODEL_ID;

        //프로젝트 속성 List
        public string PROJECT_ID;
        public string WORK_ID;

        //문서 속성 List
        public string DOC_ID;
        public string QTY;
        public string UNIT_COST;
        public string SEQ_NO;
        public string GROUP_NO;
        public string GROUP_NM_1;
        public string GROUP_NM_2;
        public string ITEM_NM;
        public string SPEC_NM;
    }
}
