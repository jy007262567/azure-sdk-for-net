// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TextAnalyticsClient.
    /// </summary>
    public static partial class TextAnalyticsClientExtensions
    {
            /// <summary>
            /// The API returns the detected language and a numeric score between 0 and 1.
            /// </summary>
            /// <remarks>
            /// Scores close to 1 indicate 100% certainty that the identified language is
            /// true. A total of 120 languages are supported.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='showStats'>
            /// (optional) if set to true, response will contain input and document level
            /// statistics.
            /// </param>
            /// <param name='languageBatchInput'>
            /// Collection of documents to analyze.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LanguageBatchResult> DetectLanguageAsync(this ITextAnalyticsClient operations, bool? showStats = default(bool?), LanguageBatchInput languageBatchInput = default(LanguageBatchInput), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DetectLanguageWithHttpMessagesAsync(showStats, languageBatchInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The API returns a list of recognized entities in a given document.
            /// </summary>
            /// <remarks>
            /// To get even more information on each recognized entity we recommend using
            /// the Bing Entity Search API by querying for the recognized entities names.
            /// See the &lt;a
            /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/text-analytics-supported-languages"&gt;Supported
            /// languages in Text Analytics API&lt;/a&gt; for the list of enabled
            /// languages.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='showStats'>
            /// (optional) if set to true, response will contain input and document level
            /// statistics.
            /// </param>
            /// <param name='multiLanguageBatchInput'>
            /// Collection of documents to analyze.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EntitiesBatchResult> EntitiesAsync(this ITextAnalyticsClient operations, bool? showStats = default(bool?), MultiLanguageBatchInput multiLanguageBatchInput = default(MultiLanguageBatchInput), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EntitiesWithHttpMessagesAsync(showStats, multiLanguageBatchInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The API returns a list of strings denoting the key talking points in the
            /// input text.
            /// </summary>
            /// <remarks>
            /// See the &lt;a
            /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview#supported-languages"&gt;Text
            /// Analytics Documentation&lt;/a&gt; for details about the languages that are
            /// supported by key phrase extraction.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='showStats'>
            /// (optional) if set to true, response will contain input and document level
            /// statistics.
            /// </param>
            /// <param name='multiLanguageBatchInput'>
            /// Collection of documents to analyze. Documents can now contain a language
            /// field to indicate the text language
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KeyPhraseBatchResult> KeyPhrasesAsync(this ITextAnalyticsClient operations, bool? showStats = default(bool?), MultiLanguageBatchInput multiLanguageBatchInput = default(MultiLanguageBatchInput), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.KeyPhrasesWithHttpMessagesAsync(showStats, multiLanguageBatchInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The API returns a numeric score between 0 and 1.
            /// </summary>
            /// <remarks>
            /// Scores close to 1 indicate positive sentiment, while scores close to 0
            /// indicate negative sentiment. A score of 0.5 indicates the lack of sentiment
            /// (e.g. a factoid statement). See the &lt;a
            /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview#supported-languages"&gt;Text
            /// Analytics Documentation&lt;/a&gt; for details about the languages that are
            /// supported by sentiment analysis.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='showStats'>
            /// (optional) if set to true, response will contain input and document level
            /// statistics.
            /// </param>
            /// <param name='multiLanguageBatchInput'>
            /// Collection of documents to analyze.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SentimentBatchResult> SentimentAsync(this ITextAnalyticsClient operations, bool? showStats = default(bool?), MultiLanguageBatchInput multiLanguageBatchInput = default(MultiLanguageBatchInput), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SentimentWithHttpMessagesAsync(showStats, multiLanguageBatchInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}