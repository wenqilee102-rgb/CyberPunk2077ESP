using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationAction : CVariable
	{
		private CEnum<gameuiCharacterCustomizationActionType> _type;
		private CString _params;
		private CBool _applyToUISlot;
		private CBool _applyImmediately;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiCharacterCustomizationActionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CString Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(2)] 
		[RED("applyToUISlot")] 
		public CBool ApplyToUISlot
		{
			get => GetProperty(ref _applyToUISlot);
			set => SetProperty(ref _applyToUISlot, value);
		}

		[Ordinal(3)] 
		[RED("applyImmediately")] 
		public CBool ApplyImmediately
		{
			get => GetProperty(ref _applyImmediately);
			set => SetProperty(ref _applyImmediately, value);
		}

		public gameuiCharacterCustomizationAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
