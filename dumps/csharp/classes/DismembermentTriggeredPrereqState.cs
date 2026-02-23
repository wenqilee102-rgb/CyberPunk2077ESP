using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentTriggeredPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CHandle<redCallbackObject> _listenerInfo;
		private DismembermentInstigatedInfo _dismembermentInfo;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listenerInfo")] 
		public CHandle<redCallbackObject> ListenerInfo
		{
			get => GetProperty(ref _listenerInfo);
			set => SetProperty(ref _listenerInfo, value);
		}

		[Ordinal(2)] 
		[RED("dismembermentInfo")] 
		public DismembermentInstigatedInfo DismembermentInfo
		{
			get => GetProperty(ref _dismembermentInfo);
			set => SetProperty(ref _dismembermentInfo, value);
		}

		public DismembermentTriggeredPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
