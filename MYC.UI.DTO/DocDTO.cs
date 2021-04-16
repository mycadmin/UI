namespace MYC.UI.DTO
{
    public struct DocDTO
    {
        //시작일시
        public string START_TM;
        //종료 일시
        public string END_TM;

        //작성자 ID
        public string USER_ID;

        //문서 번호
        public string DOC_ID;
        public string CRT_USER_ID;

        //문서 구분
        public string TYP_CD;

        //문서 종류
        public string DOC_TYP_CD;
        //내용
        public string DOC_DESC;

        //추가 구성원 ID
        public string USER_ID_LVAL;

        //출장 지역
        public string SITE_NM;
        //출장 목적
        public string SUBJECT;
    }
}
