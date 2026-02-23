using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkListItemController : inkButtonController
	{
		private inkListItemControllerCallback _toggledOff;
		private inkListItemControllerCallback _toggledOn;
		private inkListItemControllerCallback _selected_744;
		private inkListItemControllerCallback _deselected;
		private inkListItemControllerCallback _addedToList;
		private inkTextWidgetReference _labelPathRef;

		[Ordinal(13)] 
		[RED("ToggledOff")] 
		public inkListItemControllerCallback ToggledOff
		{
			get => GetProperty(ref _toggledOff);
			set => SetProperty(ref _toggledOff, value);
		}

		[Ordinal(14)] 
		[RED("ToggledOn")] 
		public inkListItemControllerCallback ToggledOn
		{
			get => GetProperty(ref _toggledOn);
			set => SetProperty(ref _toggledOn, value);
		}

		[Ordinal(15)] 
		[RED("Selected")] 
		public inkListItemControllerCallback Selected_744
		{
			get => GetProperty(ref _selected_744);
			set => SetProperty(ref _selected_744, value);
		}

		[Ordinal(16)] 
		[RED("Deselected")] 
		public inkListItemControllerCallback Deselected
		{
			get => GetProperty(ref _deselected);
			set => SetProperty(ref _deselected, value);
		}

		[Ordinal(17)] 
		[RED("AddedToList")] 
		public inkListItemControllerCallback AddedToList
		{
			get => GetProperty(ref _addedToList);
			set => SetProperty(ref _addedToList, value);
		}

		[Ordinal(18)] 
		[RED("labelPathRef")] 
		public inkTextWidgetReference LabelPathRef
		{
			get => GetProperty(ref _labelPathRef);
			set => SetProperty(ref _labelPathRef, value);
		}

		public inkListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
