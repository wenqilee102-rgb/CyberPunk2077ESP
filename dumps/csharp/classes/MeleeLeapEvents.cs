using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeLeapEvents : MeleeEventsTransition
	{
		private CBool _enableVaultFromLeapAttack;
		private CBool _exitingToMeleeStrongAttack;
		private CBool _isFinisher;
		private CBool _isTargetKnockedOver;
		private CUInt32 _textLayerId;

		[Ordinal(2)] 
		[RED("enableVaultFromLeapAttack")] 
		public CBool EnableVaultFromLeapAttack
		{
			get => GetProperty(ref _enableVaultFromLeapAttack);
			set => SetProperty(ref _enableVaultFromLeapAttack, value);
		}

		[Ordinal(3)] 
		[RED("exitingToMeleeStrongAttack")] 
		public CBool ExitingToMeleeStrongAttack
		{
			get => GetProperty(ref _exitingToMeleeStrongAttack);
			set => SetProperty(ref _exitingToMeleeStrongAttack, value);
		}

		[Ordinal(4)] 
		[RED("isFinisher")] 
		public CBool IsFinisher
		{
			get => GetProperty(ref _isFinisher);
			set => SetProperty(ref _isFinisher, value);
		}

		[Ordinal(5)] 
		[RED("isTargetKnockedOver")] 
		public CBool IsTargetKnockedOver
		{
			get => GetProperty(ref _isTargetKnockedOver);
			set => SetProperty(ref _isTargetKnockedOver, value);
		}

		[Ordinal(6)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get => GetProperty(ref _textLayerId);
			set => SetProperty(ref _textLayerId, value);
		}

		public MeleeLeapEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
