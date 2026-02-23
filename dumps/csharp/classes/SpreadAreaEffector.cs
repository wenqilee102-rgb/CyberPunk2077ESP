using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadAreaEffector : gameEffector
	{
		private CInt32 _maxTargetNum;
		private CFloat _range;
		private CArray<wCHandle<gamedataObjectAction_Record>> _objectActionsRecord;
		private wCHandle<PlayerPuppet> _player;

		[Ordinal(0)] 
		[RED("maxTargetNum")] 
		public CInt32 MaxTargetNum
		{
			get => GetProperty(ref _maxTargetNum);
			set => SetProperty(ref _maxTargetNum, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("objectActionsRecord")] 
		public CArray<wCHandle<gamedataObjectAction_Record>> ObjectActionsRecord
		{
			get => GetProperty(ref _objectActionsRecord);
			set => SetProperty(ref _objectActionsRecord, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public SpreadAreaEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
