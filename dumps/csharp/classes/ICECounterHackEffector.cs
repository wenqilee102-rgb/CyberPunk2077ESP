using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ICECounterHackEffector : gameEffector
	{
		private TweakDBID _quickhackObjectActionID;
		private wCHandle<gamedataObjectAction_Record> _quickhackObjectActionRecord;

		[Ordinal(0)] 
		[RED("quickhackObjectActionID")] 
		public TweakDBID QuickhackObjectActionID
		{
			get => GetProperty(ref _quickhackObjectActionID);
			set => SetProperty(ref _quickhackObjectActionID, value);
		}

		[Ordinal(1)] 
		[RED("quickhackObjectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> QuickhackObjectActionRecord
		{
			get => GetProperty(ref _quickhackObjectActionRecord);
			set => SetProperty(ref _quickhackObjectActionRecord, value);
		}

		public ICECounterHackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
