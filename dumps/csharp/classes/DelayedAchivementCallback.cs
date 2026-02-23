using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedAchivementCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CInt32 _id;
		private CFloat _progress;
		private CHandle<DataTrackingSystem> _dataTrackingSystem;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(2)] 
		[RED("dataTrackingSystem")] 
		public CHandle<DataTrackingSystem> DataTrackingSystem
		{
			get => GetProperty(ref _dataTrackingSystem);
			set => SetProperty(ref _dataTrackingSystem, value);
		}

		public DelayedAchivementCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
