using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayContextData : IScriptable
	{
		private wCHandle<gameObject> _player;
		private CEnum<gameItemDisplayContext> _displayContext;
		private CBool _displayComparison;
		private CArray<CName> _tags;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(2)] 
		[RED("displayComparison")] 
		public CBool DisplayComparison
		{
			get => GetProperty(ref _displayComparison);
			set => SetProperty(ref _displayComparison, value);
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		public ItemDisplayContextData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
