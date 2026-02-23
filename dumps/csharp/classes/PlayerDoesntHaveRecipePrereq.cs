using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDoesntHaveRecipePrereq : gameIScriptablePrereq
	{
		private TweakDBID _recipeID;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("recipeID")] 
		public TweakDBID RecipeID
		{
			get => GetProperty(ref _recipeID);
			set => SetProperty(ref _recipeID, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public PlayerDoesntHaveRecipePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
