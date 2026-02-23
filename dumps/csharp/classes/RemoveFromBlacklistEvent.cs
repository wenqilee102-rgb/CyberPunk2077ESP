using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveFromBlacklistEvent : redEvent
	{
		private entEntityID _entityIDToRemove;
		private CBool _isPlayerEntity;

		[Ordinal(0)] 
		[RED("entityIDToRemove")] 
		public entEntityID EntityIDToRemove
		{
			get => GetProperty(ref _entityIDToRemove);
			set => SetProperty(ref _entityIDToRemove, value);
		}

		[Ordinal(1)] 
		[RED("isPlayerEntity")] 
		public CBool IsPlayerEntity
		{
			get => GetProperty(ref _isPlayerEntity);
			set => SetProperty(ref _isPlayerEntity, value);
		}

		public RemoveFromBlacklistEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
