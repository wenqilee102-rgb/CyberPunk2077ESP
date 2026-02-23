using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCHitTypeTimeoutStruct : CVariable
	{
		private CFloat _timeout;
		private gameDelayID _delayID;

		[Ordinal(0)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(1)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		public NPCHitTypeTimeoutStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
