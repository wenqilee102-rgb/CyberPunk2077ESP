using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnMonowireWindowToSpreadQuickhackCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CHandle<MonoWireQuickHackApplyEffector> _monoWireApplyQuickhackEffector;
		private wCHandle<PlayerPuppet> _playerPuppet;

		[Ordinal(0)] 
		[RED("MonoWireApplyQuickhackEffector")] 
		public CHandle<MonoWireQuickHackApplyEffector> MonoWireApplyQuickhackEffector
		{
			get => GetProperty(ref _monoWireApplyQuickhackEffector);
			set => SetProperty(ref _monoWireApplyQuickhackEffector, value);
		}

		[Ordinal(1)] 
		[RED("PlayerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		public OnMonowireWindowToSpreadQuickhackCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
