// function highLighter($inputSelector) {
//     let deepestElement = scan($inputSelector);
//
//     function scan($selector) {
//         let childrens = $($selector).children();
//         if (childrens.length === 0) {
//             return $selector;
//         } else {
//             let childNumber = 0;
//             let childMaxChildrens = 0;
//             for (let i = 0; i < childrens.length; i++) {
//                 if ($(childrens[i]).children().length > 0) {
//                     childNumber = $(childrens[i]).children().length;
//                     childMaxChildrens = i;
//                 }
//                 return childMaxChildrens;
//             }
//         }
//     }
//
//     deepestElement.addClass('highlight');
// }

// function highLighter(selector) {
//     let targetLimit = 0;
//     function scan(target) {
//         let children = $(target).children();
//         if (children.length == 0)
//             return target;
//         let childWithMostChildren, maxChildrenCount = Number.NEGATIVE_INFINITY;
//         for (let i = 0; i < children.length; i++) {
//             if ($(children[i]).children().length > maxChildrenCount) {
//                 maxChildrenCount = $(children[i]).children().length;
//                 childWithMostChildren = i;
//             }
//         }
//         targetLimit++;
//         return scan(children[childWithMostChildren]);
//     }
//     let deepestNode = scan(selector);
//     $(deepestNode).addClass('highlight');
//     let targets = $(deepestNode).parents();
//     for (let i = 0; i < targets.length && i < targetLimit; i++)
//         $(targets[i]).addClass('highlight');
// }