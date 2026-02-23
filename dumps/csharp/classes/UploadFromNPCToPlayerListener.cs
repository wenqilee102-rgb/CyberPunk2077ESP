using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UploadFromNPCToPlayerListener : QuickHackUploadListener
	{
		private wCHandle<ScriptedPuppet> _playerPuppet;
		private wCHandle<ScriptedPuppet> _npcPuppet;
		private CArray<entEntityID> _npcSquad;
		private HUDProgressBarData _hUDData;
		private wCHandle<gameIBlackboard> _hudBlackboard;
		private CFloat _startUploadTimeStamp;
		private CBool _ssAction;
		private CBool _preventionHackLoopAction;
		private CBool _shouldStopRevealOnPreventionDeescalation;
		private CHandle<AISquadScriptInterface> _squadScriptInterface;
		private CBool _useInterruptionPrereqs;

		[Ordinal(2)] 
		[RED("playerPuppet")] 
		public wCHandle<ScriptedPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(3)] 
		[RED("npcPuppet")] 
		public wCHandle<ScriptedPuppet> NpcPuppet
		{
			get => GetProperty(ref _npcPuppet);
			set => SetProperty(ref _npcPuppet, value);
		}

		[Ordinal(4)] 
		[RED("npcSquad")] 
		public CArray<entEntityID> NpcSquad
		{
			get => GetProperty(ref _npcSquad);
			set => SetProperty(ref _npcSquad, value);
		}

		[Ordinal(5)] 
		[RED("HUDData")] 
		public HUDProgressBarData HUDData
		{
			get => GetProperty(ref _hUDData);
			set => SetProperty(ref _hUDData, value);
		}

		[Ordinal(6)] 
		[RED("hudBlackboard")] 
		public wCHandle<gameIBlackboard> HudBlackboard
		{
			get => GetProperty(ref _hudBlackboard);
			set => SetProperty(ref _hudBlackboard, value);
		}

		[Ordinal(7)] 
		[RED("startUploadTimeStamp")] 
		public CFloat StartUploadTimeStamp
		{
			get => GetProperty(ref _startUploadTimeStamp);
			set => SetProperty(ref _startUploadTimeStamp, value);
		}

		[Ordinal(8)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get => GetProperty(ref _ssAction);
			set => SetProperty(ref _ssAction, value);
		}

		[Ordinal(9)] 
		[RED("preventionHackLoopAction")] 
		public CBool PreventionHackLoopAction
		{
			get => GetProperty(ref _preventionHackLoopAction);
			set => SetProperty(ref _preventionHackLoopAction, value);
		}

		[Ordinal(10)] 
		[RED("shouldStopRevealOnPreventionDeescalation")] 
		public CBool ShouldStopRevealOnPreventionDeescalation
		{
			get => GetProperty(ref _shouldStopRevealOnPreventionDeescalation);
			set => SetProperty(ref _shouldStopRevealOnPreventionDeescalation, value);
		}

		[Ordinal(11)] 
		[RED("squadScriptInterface")] 
		public CHandle<AISquadScriptInterface> SquadScriptInterface
		{
			get => GetProperty(ref _squadScriptInterface);
			set => SetProperty(ref _squadScriptInterface, value);
		}

		[Ordinal(12)] 
		[RED("useInterruptionPrereqs")] 
		public CBool UseInterruptionPrereqs
		{
			get => GetProperty(ref _useInterruptionPrereqs);
			set => SetProperty(ref _useInterruptionPrereqs, value);
		}

		public UploadFromNPCToPlayerListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
