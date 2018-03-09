using System;

namespace WinFormsCast
{
    [Serializable]
    public partial class Cast
    {
        private string castmember;

        public string Castmember
        {
            get { return castmember; }
            set { castmember = value; }
        }
        public Cast()
        {
            this.castmember = "Cast";
        }
        public Cast(string castmember)
        {
            this.castmember = castmember;
        }
        public override String ToString()
        {
            String state;
            state = this.castmember;
            return state;
        }
    }
}
