Sample Tag Searching
====================

A very simple example showing how to use Sitecore Content Search to locate items based on the contents of a multilistfield.
Things to note:

1. The search results are populated only from the index. Storage Type had to be set to YES
2. It uses POCO classes for the results; it shows how they could, but don't need to be inheriting from SearchResultItem
3. It uses a wrapper for the SearchResults, so the search context can be closed straight away.