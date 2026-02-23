using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddToBlacklistEvent : redEvent
	{
		private entEntityID _entityIDToAdd;
		private CBool _isPlayerEntity;
		private CEnum<BlacklistReason> _reason;

		[Ordinal(0)] 
		[RED("entityIDToAdd")] 
		public entEntityID EntityIDToAdd
		{
			get => GetProperty(ref _entityIDToAdd);
			set => SetProperty(ref _entityIDToAdd, value);
		}

		[Ordinal(1)] 
		[RED("isPlayerEntity")] 
		public CBool IsPlayerEntity
		{
			get => GetProperty(ref _isPlayerEntity);
			set => SetProperty(ref _isPlayerEntity, value);
		}

		[Ordinal(2)] 
		[RED("reason")] 
		public CEnum<BlacklistReason> Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		public AddToBlacklistEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
