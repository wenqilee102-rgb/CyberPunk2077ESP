using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterSceneSpot_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CName _workName;
		private CBool _waitForEnd;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("workName")] 
		public CName WorkName
		{
			get => GetProperty(ref _workName);
			set => SetProperty(ref _workName, value);
		}

		[Ordinal(3)] 
		[RED("waitForEnd")] 
		public CBool WaitForEnd
		{
			get => GetProperty(ref _waitForEnd);
			set => SetProperty(ref _waitForEnd, value);
		}

		public questCharacterSceneSpot_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
