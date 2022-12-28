namespace Ch03Types.OutRefIn
{
    public class Referable
    {
        private int _i;
        private int[] _items = new int[10];

        public ref int FieldRef => ref _i;
        public ref int GetArrayElementRef(int index) => ref _items[index];
        public ref int GetSameRef(ref int arg) => ref arg;

        /* WILL NOT COMPILE
        public ref int GetLocalVariableRef()
        {
            int v = 420;
            return ref v;
        }*/

        /* WILL NOT COMPILE
        public ref int GetLocalRefWithMethod()
        {
            int i = 420;
            return ref GetSameRef(ref i);
        }*/

        public ref int GetIntRef(ref int i)
        {
            return ref GetSameRef(ref i);
        }
    }
}