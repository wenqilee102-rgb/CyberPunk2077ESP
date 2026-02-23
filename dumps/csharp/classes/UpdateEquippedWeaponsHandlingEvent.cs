using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateEquippedWeaponsHandlingEvent : redEvent
	{
		private CFloat _currentStaminaValue;

		[Ordinal(0)] 
		[RED("currentStaminaValue")] 
		public CFloat CurrentStaminaValue
		{
			get => GetProperty(ref _currentStaminaValue);
			set => SetProperty(ref _currentStaminaValue, value);
		}

		public UpdateEquippedWeaponsHandlingEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
