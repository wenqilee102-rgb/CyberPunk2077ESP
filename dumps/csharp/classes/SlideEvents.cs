using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlideEvents : CrouchEvents
	{
		private CBool _rumblePlayed;
		private CBool _enteredWithSprint;
		private CBool _decelerating;
		private CFloat _perkDecelerationMultiplier;
		private CHandle<gameStatModifierData_Deprecated> _addDecelerationModifier;
		private CHandle<gameStatModifierData_Deprecated> _multiplyDecelerationModifier;

		[Ordinal(6)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetProperty(ref _rumblePlayed);
			set => SetProperty(ref _rumblePlayed, value);
		}

		[Ordinal(7)] 
		[RED("enteredWithSprint")] 
		public CBool EnteredWithSprint
		{
			get => GetProperty(ref _enteredWithSprint);
			set => SetProperty(ref _enteredWithSprint, value);
		}

		[Ordinal(8)] 
		[RED("decelerating")] 
		public CBool Decelerating
		{
			get => GetProperty(ref _decelerating);
			set => SetProperty(ref _decelerating, value);
		}

		[Ordinal(9)] 
		[RED("perkDecelerationMultiplier")] 
		public CFloat PerkDecelerationMultiplier
		{
			get => GetProperty(ref _perkDecelerationMultiplier);
			set => SetProperty(ref _perkDecelerationMultiplier, value);
		}

		[Ordinal(10)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AddDecelerationModifier
		{
			get => GetProperty(ref _addDecelerationModifier);
			set => SetProperty(ref _addDecelerationModifier, value);
		}

		[Ordinal(11)] 
		[RED("multiplyDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> MultiplyDecelerationModifier
		{
			get => GetProperty(ref _multiplyDecelerationModifier);
			set => SetProperty(ref _multiplyDecelerationModifier, value);
		}

		public SlideEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
