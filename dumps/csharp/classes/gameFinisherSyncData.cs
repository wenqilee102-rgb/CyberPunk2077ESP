using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFinisherSyncData : CVariable
	{
		private CName _syncAnimSlotName;
		private TweakDBID _effector;

		[Ordinal(0)] 
		[RED("syncAnimSlotName")] 
		public CName SyncAnimSlotName
		{
			get => GetProperty(ref _syncAnimSlotName);
			set => SetProperty(ref _syncAnimSlotName, value);
		}

		[Ordinal(1)] 
		[RED("effector")] 
		public TweakDBID Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}

		public gameFinisherSyncData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
