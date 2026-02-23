using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetPage_ : gameJournalEntry
	{
		private CString _address;
		private CArray<gameJournalFactNameValue> _factsToSet;
		private CBool _additionallyFilledFromScripts;
		private CBool _reloadOnZoomIn;
		private raRef<inkWidgetLibraryResource> _widgetFile;
		private CFloat _scale;
		private CArray<CHandle<gameJournalInternetText>> _texts;
		private CArray<CHandle<gameJournalInternetRectangle>> _rectangles;
		private CArray<CHandle<gameJournalInternetImage>> _images;
		private CArray<CHandle<gameJournalInternetVideo>> _videos;
		private CArray<CHandle<gameJournalInternetCanvas>> _canvases;

		[Ordinal(2)] 
		[RED("address")] 
		public CString Address
		{
			get => GetProperty(ref _address);
			set => SetProperty(ref _address, value);
		}

		[Ordinal(3)] 
		[RED("factsToSet")] 
		public CArray<gameJournalFactNameValue> FactsToSet
		{
			get => GetProperty(ref _factsToSet);
			set => SetProperty(ref _factsToSet, value);
		}

		[Ordinal(4)] 
		[RED("additionallyFilledFromScripts")] 
		public CBool AdditionallyFilledFromScripts
		{
			get => GetProperty(ref _additionallyFilledFromScripts);
			set => SetProperty(ref _additionallyFilledFromScripts, value);
		}

		[Ordinal(5)] 
		[RED("reloadOnZoomIn")] 
		public CBool ReloadOnZoomIn
		{
			get => GetProperty(ref _reloadOnZoomIn);
			set => SetProperty(ref _reloadOnZoomIn, value);
		}

		[Ordinal(6)] 
		[RED("widgetFile")] 
		public raRef<inkWidgetLibraryResource> WidgetFile
		{
			get => GetProperty(ref _widgetFile);
			set => SetProperty(ref _widgetFile, value);
		}

		[Ordinal(7)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(8)] 
		[RED("texts")] 
		public CArray<CHandle<gameJournalInternetText>> Texts
		{
			get => GetProperty(ref _texts);
			set => SetProperty(ref _texts, value);
		}

		[Ordinal(9)] 
		[RED("rectangles")] 
		public CArray<CHandle<gameJournalInternetRectangle>> Rectangles
		{
			get => GetProperty(ref _rectangles);
			set => SetProperty(ref _rectangles, value);
		}

		[Ordinal(10)] 
		[RED("images")] 
		public CArray<CHandle<gameJournalInternetImage>> Images
		{
			get => GetProperty(ref _images);
			set => SetProperty(ref _images, value);
		}

		[Ordinal(11)] 
		[RED("videos")] 
		public CArray<CHandle<gameJournalInternetVideo>> Videos
		{
			get => GetProperty(ref _videos);
			set => SetProperty(ref _videos, value);
		}

		[Ordinal(12)] 
		[RED("canvases")] 
		public CArray<CHandle<gameJournalInternetCanvas>> Canvases
		{
			get => GetProperty(ref _canvases);
			set => SetProperty(ref _canvases, value);
		}

		public gameJournalInternetPage_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
