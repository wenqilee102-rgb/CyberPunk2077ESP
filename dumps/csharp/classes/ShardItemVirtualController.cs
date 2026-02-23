using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardItemVirtualController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _icon;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _counter;
		private inkWidgetReference _collapseIcon;
		private inkWidgetReference _isNewFlag;
		private CHandle<ShardEntryData> _entryData;
		private CHandle<VirutalNestedListData> _nestedListData;
		private wCHandle<CodexListSyncData> _activeItemSync;
		private CBool _isActive;
		private CBool _isItemHovered;
		private CBool _isItemToggled;
		private CBool _isItemCollapsed;
		private CBool _clicked;

		[Ordinal(18)] 
		[RED("icon")] 
		public inkWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(19)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(20)] 
		[RED("counter")] 
		public inkTextWidgetReference Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(21)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get => GetProperty(ref _collapseIcon);
			set => SetProperty(ref _collapseIcon, value);
		}

		[Ordinal(22)] 
		[RED("isNewFlag")] 
		public inkWidgetReference IsNewFlag
		{
			get => GetProperty(ref _isNewFlag);
			set => SetProperty(ref _isNewFlag, value);
		}

		[Ordinal(23)] 
		[RED("entryData")] 
		public CHandle<ShardEntryData> EntryData
		{
			get => GetProperty(ref _entryData);
			set => SetProperty(ref _entryData, value);
		}

		[Ordinal(24)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get => GetProperty(ref _nestedListData);
			set => SetProperty(ref _nestedListData, value);
		}

		[Ordinal(25)] 
		[RED("activeItemSync")] 
		public wCHandle<CodexListSyncData> ActiveItemSync
		{
			get => GetProperty(ref _activeItemSync);
			set => SetProperty(ref _activeItemSync, value);
		}

		[Ordinal(26)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(27)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetProperty(ref _isItemHovered);
			set => SetProperty(ref _isItemHovered, value);
		}

		[Ordinal(28)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetProperty(ref _isItemToggled);
			set => SetProperty(ref _isItemToggled, value);
		}

		[Ordinal(29)] 
		[RED("isItemCollapsed")] 
		public CBool IsItemCollapsed
		{
			get => GetProperty(ref _isItemCollapsed);
			set => SetProperty(ref _isItemCollapsed, value);
		}

		[Ordinal(30)] 
		[RED("clicked")] 
		public CBool Clicked
		{
			get => GetProperty(ref _clicked);
			set => SetProperty(ref _clicked, value);
		}

		public ShardItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
