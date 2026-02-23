using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NumericDisplayBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Int32 _currentNumber;
		private gamebbScriptID_Int32 _direction;

		[Ordinal(7)] 
		[RED("CurrentNumber")] 
		public gamebbScriptID_Int32 CurrentNumber
		{
			get => GetProperty(ref _currentNumber);
			set => SetProperty(ref _currentNumber, value);
		}

		[Ordinal(8)] 
		[RED("Direction")] 
		public gamebbScriptID_Int32 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public NumericDisplayBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
