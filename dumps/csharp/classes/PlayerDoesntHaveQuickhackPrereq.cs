using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDoesntHaveQuickhackPrereq : gameIScriptablePrereq
	{
		private TweakDBID _quickhackID;

		[Ordinal(0)] 
		[RED("quickhackID")] 
		public TweakDBID QuickhackID
		{
			get => GetProperty(ref _quickhackID);
			set => SetProperty(ref _quickhackID, value);
		}

		public PlayerDoesntHaveQuickhackPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
