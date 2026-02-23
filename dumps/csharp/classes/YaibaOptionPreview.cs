using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class YaibaOptionPreview : inkWidgetLogicController
	{
		private inkWidgetReference _selectionPreviewRef;
		private inkWidgetReference _removalPreviewRef;
		private CName _selectionAnimName;
		private CName _removalAnimName;
		private CBool _active;
		private CBool _isAnimated;
		private CHandle<inkanimProxy> _proxy;

		[Ordinal(1)] 
		[RED("selectionPreviewRef")] 
		public inkWidgetReference SelectionPreviewRef
		{
			get => GetProperty(ref _selectionPreviewRef);
			set => SetProperty(ref _selectionPreviewRef, value);
		}

		[Ordinal(2)] 
		[RED("removalPreviewRef")] 
		public inkWidgetReference RemovalPreviewRef
		{
			get => GetProperty(ref _removalPreviewRef);
			set => SetProperty(ref _removalPreviewRef, value);
		}

		[Ordinal(3)] 
		[RED("selectionAnimName")] 
		public CName SelectionAnimName
		{
			get => GetProperty(ref _selectionAnimName);
			set => SetProperty(ref _selectionAnimName, value);
		}

		[Ordinal(4)] 
		[RED("removalAnimName")] 
		public CName RemovalAnimName
		{
			get => GetProperty(ref _removalAnimName);
			set => SetProperty(ref _removalAnimName, value);
		}

		[Ordinal(5)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(6)] 
		[RED("isAnimated")] 
		public CBool IsAnimated
		{
			get => GetProperty(ref _isAnimated);
			set => SetProperty(ref _isAnimated, value);
		}

		[Ordinal(7)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetProperty(ref _proxy);
			set => SetProperty(ref _proxy, value);
		}

		public YaibaOptionPreview(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
