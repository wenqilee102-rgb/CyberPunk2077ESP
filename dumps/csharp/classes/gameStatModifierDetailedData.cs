using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierDetailedData : CVariable
	{
		private CFloat _value;
		private CEnum<gameStatModifierType> _modifierType;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("modifierType")] 
		public CEnum<gameStatModifierType> ModifierType
		{
			get => GetProperty(ref _modifierType);
			set => SetProperty(ref _modifierType, value);
		}

		public gameStatModifierDetailedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
