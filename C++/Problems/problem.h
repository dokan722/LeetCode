#ifndef IPROBLEM_H
#define IPROBLEM_H
#include <iostream>
#include <vector>


class problem {
public:
    virtual ~problem() = default;

    virtual bool test() = 0;

    template<class T>
    void print1DVector(const std::vector<T> &arr, std::string valueSeparator = ", ");

    template<class T>
    void print2DVector(const std::vector<std::vector<T>> &arr, std::string valueSeparator = ", ", std::string lineSeparator = "\n");
};

template <typename T>
void problem::print1DVector(const std::vector<T> &arr, std::string valueSeparator) {
    for (int i = 0; i < arr.size() - 1; i++)
        std::cout << arr[i] << valueSeparator;
    std::cout << arr[arr.size() - 1] << std::endl;
}

template<class T>
void problem::print2DVector(const std::vector<std::vector<T>> &arr, std::string valueSeparator, std::string lineSeparator) {
    for (int i = 0; i < arr.size() - 1; i++) {
        print1DVector(arr[i], valueSeparator);
        std::cout << lineSeparator;
    }
}

#endif
