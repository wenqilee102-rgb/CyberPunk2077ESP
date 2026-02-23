using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapFiltersListItem : inkWidgetLogicController
	{
		private inkWidgetReference _checker;
		private inkTextWidgetReference _filterName;
		private wCHandle<gamedataMappinUIFilterGroup_Record> _filterGroup;
		private wCHandle<inkWidget> _rootWidget;
		private CBool _isHovered;

		[Ordinal(1)] 
		[RED("checker")] 
		public inkWidgetReference Checker
		{
			get => GetProperty(ref _checker);
			set => SetProperty(ref _checker, value);
		}

		[Ordinal(2)] 
		[RED("filterName")] 
		public inkTextWidgetReference FilterName
		{
			get => GetProperty(ref _filterName);
			set => SetProperty(ref _filterName, value);
		}

		[Ordinal(3)] 
		[RED("filterGroup")] 
		public wCHandle<gamedataMappinUIFilterGroup_Record> FilterGroup
		{
			get => GetProperty(ref _filterGroup);
			set => SetProperty(ref _filterGroup, value);
		}

		[Ordinal(4)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(5)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		public WorldMapFiltersListItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
