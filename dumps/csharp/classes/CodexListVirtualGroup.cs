using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualGroup : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _title;
		private inkWidgetReference _arrow;
		private inkWidgetReference _newWrapper;
		private inkTextWidgetReference _counter;
		private CHandle<CodexEntryData> _entryData;
		private CHandle<VirutalNestedListData> _nestedListData;
		private wCHandle<CodexListSyncData> _activeItemSync;
		private CBool _isActive;
		private CBool _isItemHovered;
		private CBool _isItemToggled;
		private CBool _isItemCollapsed;

		[Ordinal(18)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(19)] 
		[RED("arrow")] 
		public inkWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(20)] 
		[RED("newWrapper")] 
		public inkWidgetReference NewWrapper
		{
			get => GetProperty(ref _newWrapper);
			set => SetProperty(ref _newWrapper, value);
		}

		[Ordinal(21)] 
		[RED("counter")] 
		public inkTextWidgetReference Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(22)] 
		[RED("entryData")] 
		public CHandle<CodexEntryData> EntryData
		{
			get => GetProperty(ref _entryData);
			set => SetProperty(ref _entryData, value);
		}

		[Ordinal(23)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get => GetProperty(ref _nestedListData);
			set => SetProperty(ref _nestedListData, value);
		}

		[Ordinal(24)] 
		[RED("activeItemSync")] 
		public wCHandle<CodexListSyncData> ActiveItemSync
		{
			get => GetProperty(ref _activeItemSync);
			set => SetProperty(ref _activeItemSync, value);
		}

		[Ordinal(25)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(26)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetProperty(ref _isItemHovered);
			set => SetProperty(ref _isItemHovered, value);
		}

		[Ordinal(27)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetProperty(ref _isItemToggled);
			set => SetProperty(ref _isItemToggled, value);
		}

		[Ordinal(28)] 
		[RED("isItemCollapsed")] 
		public CBool IsItemCollapsed
		{
			get => GetProperty(ref _isItemCollapsed);
			set => SetProperty(ref _isItemCollapsed, value);
		}

		public CodexListVirtualGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
