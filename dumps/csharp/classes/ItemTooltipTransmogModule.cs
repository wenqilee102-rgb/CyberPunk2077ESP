using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipTransmogModule : ItemTooltipModuleController
	{
		private inkWidgetReference _buttonHintWidgetRef;
		private inkTextWidgetReference _labelRef;
		private wCHandle<LabelInputDisplayController> _buttonHint;

		[Ordinal(5)] 
		[RED("buttonHintWidgetRef")] 
		public inkWidgetReference ButtonHintWidgetRef
		{
			get => GetProperty(ref _buttonHintWidgetRef);
			set => SetProperty(ref _buttonHintWidgetRef, value);
		}

		[Ordinal(6)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetProperty(ref _labelRef);
			set => SetProperty(ref _labelRef, value);
		}

		[Ordinal(7)] 
		[RED("buttonHint")] 
		public wCHandle<LabelInputDisplayController> ButtonHint
		{
			get => GetProperty(ref _buttonHint);
			set => SetProperty(ref _buttonHint, value);
		}

		public ItemTooltipTransmogModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
