using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocCategoryTooltip : AGenericTooltipController
	{
		private inkTextWidgetReference _desc;
		private inkTextWidgetReference _availableLabelCounter;
		private inkTextWidgetReference _ownedLabelCounter;
		private inkWidgetReference _ownedLabel;
		private inkWidgetReference _availableLabel;
		private inkWidgetReference _nALabel;

		[Ordinal(2)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(3)] 
		[RED("availableLabelCounter")] 
		public inkTextWidgetReference AvailableLabelCounter
		{
			get => GetProperty(ref _availableLabelCounter);
			set => SetProperty(ref _availableLabelCounter, value);
		}

		[Ordinal(4)] 
		[RED("ownedLabelCounter")] 
		public inkTextWidgetReference OwnedLabelCounter
		{
			get => GetProperty(ref _ownedLabelCounter);
			set => SetProperty(ref _ownedLabelCounter, value);
		}

		[Ordinal(5)] 
		[RED("ownedLabel")] 
		public inkWidgetReference OwnedLabel
		{
			get => GetProperty(ref _ownedLabel);
			set => SetProperty(ref _ownedLabel, value);
		}

		[Ordinal(6)] 
		[RED("availableLabel")] 
		public inkWidgetReference AvailableLabel
		{
			get => GetProperty(ref _availableLabel);
			set => SetProperty(ref _availableLabel, value);
		}

		[Ordinal(7)] 
		[RED("NALabel")] 
		public inkWidgetReference NALabel
		{
			get => GetProperty(ref _nALabel);
			set => SetProperty(ref _nALabel, value);
		}

		public RipperdocCategoryTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
