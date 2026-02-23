using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InnerBunkerSystemStatusLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _onlineRoot;
		private inkWidgetReference _offlineRoot;
		private inkWidgetReference _onlineIco;
		private inkWidgetReference _offlineIco;
		private inkWidgetReference _sysIndicator;
		private CName _stateAnimName;
		private CArray<inkWidgetReference> _widgetsToColor;
		private CArray<inkTextWidgetReference> _textStatuses;

		[Ordinal(1)] 
		[RED("onlineRoot")] 
		public inkWidgetReference OnlineRoot
		{
			get => GetProperty(ref _onlineRoot);
			set => SetProperty(ref _onlineRoot, value);
		}

		[Ordinal(2)] 
		[RED("offlineRoot")] 
		public inkWidgetReference OfflineRoot
		{
			get => GetProperty(ref _offlineRoot);
			set => SetProperty(ref _offlineRoot, value);
		}

		[Ordinal(3)] 
		[RED("onlineIco")] 
		public inkWidgetReference OnlineIco
		{
			get => GetProperty(ref _onlineIco);
			set => SetProperty(ref _onlineIco, value);
		}

		[Ordinal(4)] 
		[RED("offlineIco")] 
		public inkWidgetReference OfflineIco
		{
			get => GetProperty(ref _offlineIco);
			set => SetProperty(ref _offlineIco, value);
		}

		[Ordinal(5)] 
		[RED("sysIndicator")] 
		public inkWidgetReference SysIndicator
		{
			get => GetProperty(ref _sysIndicator);
			set => SetProperty(ref _sysIndicator, value);
		}

		[Ordinal(6)] 
		[RED("stateAnimName")] 
		public CName StateAnimName
		{
			get => GetProperty(ref _stateAnimName);
			set => SetProperty(ref _stateAnimName, value);
		}

		[Ordinal(7)] 
		[RED("widgetsToColor")] 
		public CArray<inkWidgetReference> WidgetsToColor
		{
			get => GetProperty(ref _widgetsToColor);
			set => SetProperty(ref _widgetsToColor, value);
		}

		[Ordinal(8)] 
		[RED("textStatuses")] 
		public CArray<inkTextWidgetReference> TextStatuses
		{
			get => GetProperty(ref _textStatuses);
			set => SetProperty(ref _textStatuses, value);
		}

		public InnerBunkerSystemStatusLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
