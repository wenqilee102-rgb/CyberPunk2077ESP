using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputStates : gameMuppetComponent
	{
		private netTime _replicationTime;

		[Ordinal(3)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetProperty(ref _replicationTime);
			set => SetProperty(ref _replicationTime, value);
		}

		public gameMuppetInputStates(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
