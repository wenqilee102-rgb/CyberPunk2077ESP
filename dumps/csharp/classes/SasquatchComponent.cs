using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SasquatchComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private CBool _weakspotDestroyed;
		private wCHandle<PlayerPuppet> _player;

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetProperty(ref _owner_id);
			set => SetProperty(ref _owner_id, value);
		}

		[Ordinal(7)] 
		[RED("weakspotDestroyed")] 
		public CBool WeakspotDestroyed
		{
			get => GetProperty(ref _weakspotDestroyed);
			set => SetProperty(ref _weakspotDestroyed, value);
		}

		[Ordinal(8)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public SasquatchComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
