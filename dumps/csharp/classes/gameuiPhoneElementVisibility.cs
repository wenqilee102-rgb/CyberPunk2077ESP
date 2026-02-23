using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneElementVisibility : CVariable
	{
		private CEnum<worlduiContextVisibility> _tierVisibility;
		private CEnum<gameuiContext> _gameContextVisibility;
		private inkCompoundWidgetReference _slot;

		[Ordinal(0)] 
		[RED("tierVisibility")] 
		public CEnum<worlduiContextVisibility> TierVisibility
		{
			get => GetProperty(ref _tierVisibility);
			set => SetProperty(ref _tierVisibility, value);
		}

		[Ordinal(1)] 
		[RED("gameContextVisibility")] 
		public CEnum<gameuiContext> GameContextVisibility
		{
			get => GetProperty(ref _gameContextVisibility);
			set => SetProperty(ref _gameContextVisibility, value);
		}

		[Ordinal(2)] 
		[RED("slot")] 
		public inkCompoundWidgetReference Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public gameuiPhoneElementVisibility(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
