using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocCwPreviewItemController : inkWidgetLogicController
	{
		private inkWidgetReference _itemIcon;
		private inkWidgetReference _addIcon;
		private wCHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("itemIcon")] 
		public inkWidgetReference ItemIcon
		{
			get => GetProperty(ref _itemIcon);
			set => SetProperty(ref _itemIcon, value);
		}

		[Ordinal(2)] 
		[RED("addIcon")] 
		public inkWidgetReference AddIcon
		{
			get => GetProperty(ref _addIcon);
			set => SetProperty(ref _addIcon, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public RipperdocCwPreviewItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
