using System;

namespace Q7
{
	class Program
	{
		static void Main(string[] args)
		{
			
		}
	}

	class Car<TEngine> where TEngine : Engine
	{
		public TEngine Engine;

		public virtual void ChangePart<TPart>(TPart newPart ) where TPart : CarPart
		{

        }
}
	}

    class ElectricEngine : Engine
    {

    }

	class GasEngine : Engine
{

    }
	class Battery : CarPart
{

    }
    class Differential : CarPart
{

    }
	class Wheel : CarPart
{

    }

}

