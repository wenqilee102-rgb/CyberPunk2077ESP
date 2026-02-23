using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClothingSetController : BaseButtonView
	{
		private inkTextWidgetReference _setName;
		private CHandle<gameClothingSet> _clothingSet;
		private CBool _equipped;
		private CBool _selected;
		private CBool _defined;
		private CBool _isHovered;
		private CBool _hasChanges;
		private CBool _disabled;
		private wCHandle<inkWidget> _styleWidget;

		[Ordinal(5)] 
		[RED("setName")] 
		public inkTextWidgetReference SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}

		[Ordinal(6)] 
		[RED("clothingSet")] 
		public CHandle<gameClothingSet> ClothingSet
		{
			get => GetProperty(ref _clothingSet);
			set => SetProperty(ref _clothingSet, value);
		}

		[Ordinal(7)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetProperty(ref _equipped);
			set => SetProperty(ref _equipped, value);
		}

		[Ordinal(8)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}

		[Ordinal(9)] 
		[RED("defined")] 
		public CBool Defined
		{
			get => GetProperty(ref _defined);
			set => SetProperty(ref _defined, value);
		}

		[Ordinal(10)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		[Ordinal(11)] 
		[RED("hasChanges")] 
		public CBool HasChanges
		{
			get => GetProperty(ref _hasChanges);
			set => SetProperty(ref _hasChanges, value);
		}

		[Ordinal(12)] 
		[RED("disabled")] 
		public CBool Disabled
		{
			get => GetProperty(ref _disabled);
			set => SetProperty(ref _disabled, value);
		}

		[Ordinal(13)] 
		[RED("styleWidget")] 
		public wCHandle<inkWidget> StyleWidget
		{
			get => GetProperty(ref _styleWidget);
			set => SetProperty(ref _styleWidget, value);
		}

		public ClothingSetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
