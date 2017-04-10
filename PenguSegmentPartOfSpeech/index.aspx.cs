using System;
using PanGu;

namespace PenguSegmentPartOfSpeech
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


         
        }

        protected void btnSplit_Click(object sender, EventArgs e)
        {
       
            ltlResult.Text = "";
            var segment = new PanGu.Segment();
            var words = segment.DoSegment(txtContent.Text);
            foreach (var word in words)
            {
               ltlResult.Text+=(word + "," + GetChsPos(word.Pos) + "<br />");
            }
        }


       
        private string GetChsPos(POS pos)
        {
         
            switch (pos)
            {
                case POS.POS_UNK:
                    return "未知詞性";
                case POS.POS_D_K:
                    return "後接成分";
                case POS.POS_D_H:
                    return "前接成分";
                case POS.POS_A_NZ:
                    return "其他專名";
                case POS.POS_A_NX:
                    return "外文字符";
                case POS.POS_A_NR:
                    return "人名";
                case POS.POS_D_Z:
                    return "狀態詞";
                case POS.POS_A_NT:
                    return "機構團體";
                case POS.POS_A_NS:
                    return "地名";
                case POS.POS_D_Y:
                    return "語氣詞 語氣語素";
                case POS.POS_D_X:
                    return "非語素字";
                case POS.POS_D_W:
                    return "標點符號";
                case POS.POS_D_T:
                    return "時間詞";
                case POS.POS_D_S:
                    return "處所詞";
                case POS.POS_D_V:
                    return "動詞 動語素";
                case POS.POS_D_U:
                    return "助詞 助語素";
                case POS.POS_D_R:
                    return "代詞 代語素";
                case POS.POS_A_Q:
                    return "量詞 量語素";
                case POS.POS_D_P:
                    return "介詞";
                case POS.POS_D_MQ:
                    return "數量詞";
                case POS.POS_A_M:
                    return "數詞 數語素";
                case POS.POS_D_O:
                    return "擬聲詞";
                case POS.POS_D_N:
                    return "名詞 名語素";
                case POS.POS_D_F:
                    return "方位詞 方位語素";
                case POS.POS_D_E:
                    return "嘆詞 嘆語素";
                case POS.POS_D_L:
                    return "習語";
                case POS.POS_D_I:
                    return "成語";
                case POS.POS_D_D:
                    return "副詞 副語素";
                case POS.POS_D_C:
                    return "連詞 連語素";
                case POS.POS_D_B:
                    return "區別詞 區別語素";
                case POS.POS_D_A:
                    return "形容詞 形語素";
            }
            return "未知詞性";
        }
    }
}