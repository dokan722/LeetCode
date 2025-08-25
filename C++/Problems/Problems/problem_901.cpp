#include "problem_901.h"

StockSpanner::StockSpanner() {
    _spanStack = std::stack<std::pair<int, int>>();
}

int StockSpanner::next(int price) {
    int span = 1;
    while (!_spanStack.empty() && _spanStack.top().first <= price)
    {
        auto item = _spanStack.top();
        _spanStack.pop();
        span += item.second;
    }
    _spanStack.push(std::pair(price, span));
    return span;
}

bool problem_901::test() {
    StockSpanner stockSpanner;
    if (stockSpanner.next(100) != 1)
        return false;
    if (stockSpanner.next(80) != 1)
        return false;
    if (stockSpanner.next(60) != 1)
        return false;
    if (stockSpanner.next(70) != 2)
        return false;
    if (stockSpanner.next(60) != 1)
        return false;
    if (stockSpanner.next(75) != 4)
        return false;
    if (stockSpanner.next(85) != 6)
        return false;

    return true;
}
