#include <iostream>
#include "Problems/problems.h"
#include "resources.h"


int main() {
    auto problem = problem_3159();
    if (problem.test())
    {
        std::cout << "\n";
        std::cout << resources::ezpz << "\n";
    }
    else
    {
        std::cout << "\n";
        std::cout << resources::nah << "\n";
    }


    return 0;
}