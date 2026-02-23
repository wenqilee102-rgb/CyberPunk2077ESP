using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NumericDisplayControllerPS : ScriptableDeviceComponentPS
	{
		private CInt32 _numberToDisplay;
		private CInt32 _targetNumber;

		[Ordinal(107)] 
		[RED("numberToDisplay")] 
		public CInt32 NumberToDisplay
		{
			get => GetProperty(ref _numberToDisplay);
			set => SetProperty(ref _numberToDisplay, value);
		}

		[Ordinal(108)] 
		[RED("targetNumber")] 
		public CInt32 TargetNumber
		{
			get => GetProperty(ref _targetNumber);
			set => SetProperty(ref _targetNumber, value);
		}

		public NumericDisplayControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
