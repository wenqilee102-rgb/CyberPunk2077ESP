using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentSystem : gameScriptableSystem
	{
		private CArray<CHandle<PlayerDevelopmentData>> _playerData;
		private CBool _playerDevelopmentUpdated;
		private CBool _progressionBuildUpdated;

		[Ordinal(0)] 
		[RED("playerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> PlayerData
		{
			get => GetProperty(ref _playerData);
			set => SetProperty(ref _playerData, value);
		}

		[Ordinal(1)] 
		[RED("playerDevelopmentUpdated")] 
		public CBool PlayerDevelopmentUpdated
		{
			get => GetProperty(ref _playerDevelopmentUpdated);
			set => SetProperty(ref _playerDevelopmentUpdated, value);
		}

		[Ordinal(2)] 
		[RED("progressionBuildUpdated")] 
		public CBool ProgressionBuildUpdated
		{
			get => GetProperty(ref _progressionBuildUpdated);
			set => SetProperty(ref _progressionBuildUpdated, value);
		}

		public PlayerDevelopmentSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
