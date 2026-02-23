using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimTranslationBetweenWidgetsInterpolator : inkanimTranslationInterpolator
	{
		private CName _startWidgetPath;
		private CName _endWidgetPath;

		[Ordinal(9)] 
		[RED("startWidgetPath")] 
		public CName StartWidgetPath
		{
			get => GetProperty(ref _startWidgetPath);
			set => SetProperty(ref _startWidgetPath, value);
		}

		[Ordinal(10)] 
		[RED("endWidgetPath")] 
		public CName EndWidgetPath
		{
			get => GetProperty(ref _endWidgetPath);
			set => SetProperty(ref _endWidgetPath, value);
		}

		public inkanimTranslationBetweenWidgetsInterpolator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
