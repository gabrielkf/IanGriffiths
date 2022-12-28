namespace Ch03Types.OutRefIn
{
    public class Referable
    {
        private int i;
        private int[] items = new int[10];

        public ref int FieldRef => ref i;
        public ref int GetArrayElementRef(int index) => ref items[index];
        public ref int GetSameRef(ref int arg) => ref arg;

        /* WILL NOT COMPILE
        public ref int GetLocalVariableRef()
        {
            int v = 420;
            return ref v;
        }
        */

        public ref int GetLocalRefWithMethod()
        {
            int i = 420;
            return ref GetSameRef(ref i);
        }
    }
}