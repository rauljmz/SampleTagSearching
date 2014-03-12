Sample Tag Searching
====================

A very simple example showing how to use Sitecore Content Search to locate items based on the contents of a multilistfield.
Things to note:

1. The search results are populated only from the index. Storage Type had to be set to YES
2. It uses POCO classes for the results; it shows how they could, but don't need to, inherit from SearchResultItem
3. Retrieves the possible tag values using Content Search too (something we would have traditionally done with Sitecore Search)
3. There is a wrapper for the SearchResults, so the search context can be closed straight away.