using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyLoopMetadata : CVariable
	{
		private CName _startEvent;
		private CName _stopEvent;

		[Ordinal(0)] 
		[RED("startEvent")] 
		public CName StartEvent
		{
			get => GetProperty(ref _startEvent);
			set => SetProperty(ref _startEvent, value);
		}

		[Ordinal(1)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetProperty(ref _stopEvent);
			set => SetProperty(ref _stopEvent, value);
		}

		public audioFoleyLoopMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
