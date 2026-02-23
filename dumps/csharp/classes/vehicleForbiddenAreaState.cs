using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleForbiddenAreaState : CVariable
	{
		private CUInt64 _globalNodeIDHash;
		private CBool _enabled;
		private CBool _dismount;
		private CBool _blockCombat;

		[Ordinal(0)] 
		[RED("globalNodeIDHash")] 
		public CUInt64 GlobalNodeIDHash
		{
			get => GetProperty(ref _globalNodeIDHash);
			set => SetProperty(ref _globalNodeIDHash, value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(2)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get => GetProperty(ref _dismount);
			set => SetProperty(ref _dismount, value);
		}

		[Ordinal(3)] 
		[RED("blockCombat")] 
		public CBool BlockCombat
		{
			get => GetProperty(ref _blockCombat);
			set => SetProperty(ref _blockCombat, value);
		}

		public vehicleForbiddenAreaState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
