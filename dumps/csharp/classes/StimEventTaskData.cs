using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimEventTaskData : gameScriptTaskData
	{
		private CHandle<senseStimuliEvent> _cachedEvt;
		private CBool _delayed;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<senseStimuliEvent> CachedEvt
		{
			get => GetProperty(ref _cachedEvt);
			set => SetProperty(ref _cachedEvt, value);
		}

		[Ordinal(1)] 
		[RED("delayed")] 
		public CBool Delayed
		{
			get => GetProperty(ref _delayed);
			set => SetProperty(ref _delayed, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public StimEventTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
