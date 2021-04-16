namespace MYC.UI.DTO
{
    public struct ProductDTO
    {
        //공통 속성 List
        public string COMP_CD;
        public string USER_ID;
        public string DESC;

        //발주 속성 List
        public string MODEL_ID;
        public string QTY;
        public string QTY_CD;
        public string UNIT_COST;
        public string DELI_DT;

        //문서 속성 List
        public string DOC_ID;
        public string ORDER_COMP_CD;
    }
}
