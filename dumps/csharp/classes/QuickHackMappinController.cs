using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackMappinController : gameuiInteractionMappinController
	{
		private inkWidgetReference _bar;
		private inkTextWidgetReference _header;
		private inkImageWidgetReference _iconWidgetActive;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<gamemappinsIMappin> _mappin;
		private CHandle<GameplayRoleMappinData> _data;
		private CArray<inkWidgetReference> _queueQuickHackWidgets;
		private CArray<wCHandle<QuickHackQueueItem>> _queueQuickHackControllers;
		private CArray<CHandle<GameplayRoleMappinData>> _mappinDataQueue;
		private CHandle<inkanimProxy> _animUpload;
		private CHandle<inkanimProxy> _animQueue;

		[Ordinal(11)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(12)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(13)] 
		[RED("iconWidgetActive")] 
		public inkImageWidgetReference IconWidgetActive
		{
			get => GetProperty(ref _iconWidgetActive);
			set => SetProperty(ref _iconWidgetActive, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(17)] 
		[RED("queueQuickHackWidgets")] 
		public CArray<inkWidgetReference> QueueQuickHackWidgets
		{
			get => GetProperty(ref _queueQuickHackWidgets);
			set => SetProperty(ref _queueQuickHackWidgets, value);
		}

		[Ordinal(18)] 
		[RED("queueQuickHackControllers")] 
		public CArray<wCHandle<QuickHackQueueItem>> QueueQuickHackControllers
		{
			get => GetProperty(ref _queueQuickHackControllers);
			set => SetProperty(ref _queueQuickHackControllers, value);
		}

		[Ordinal(19)] 
		[RED("mappinDataQueue")] 
		public CArray<CHandle<GameplayRoleMappinData>> MappinDataQueue
		{
			get => GetProperty(ref _mappinDataQueue);
			set => SetProperty(ref _mappinDataQueue, value);
		}

		[Ordinal(20)] 
		[RED("animUpload")] 
		public CHandle<inkanimProxy> AnimUpload
		{
			get => GetProperty(ref _animUpload);
			set => SetProperty(ref _animUpload, value);
		}

		[Ordinal(21)] 
		[RED("animQueue")] 
		public CHandle<inkanimProxy> AnimQueue
		{
			get => GetProperty(ref _animQueue);
			set => SetProperty(ref _animQueue, value);
		}

		public QuickHackMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
