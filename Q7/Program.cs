using System;

namespace Q7
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}
	class IndexingClass
	{
		private int[] array;

		public IndexingClass(int[] array)
		{
			this.array = array;
		}

        public int this[int index]
        {
			get
			{
				return array[index];
			}

			set
			{
				array[index] = value;
			}
		}
    }
}

