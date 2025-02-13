'use strict'

const path = require('path')
const autoprefixer = require('autoprefixer')
const minicss = require('mini-css-extract-plugin')
const terser = require('terser-webpack-plugin')
const remove = require('webpack-remove-empty-scripts')

module.exports = {
    mode: 'production',
    entry: {
        'bootstrap': './Stylesheets/bootstrap.scss',
        'k6': './Stylesheets/k6.scss',
        'fastbootstrap': './Stylesheets/fastbootstrap.scss',
        'flatly': './Stylesheets/flatly.scss',
        'lumen': './Stylesheets/lumen.scss',
        'materia': './Stylesheets/materia.scss',
        'minty': './Stylesheets/minty.scss',
        'quartz': './Stylesheets/quartz.scss',
        'sketchy': './Stylesheets/sketchy.scss',
        'united': './Stylesheets/united.scss',
    },
    output: {
        filename: '[name].js',
        path: path.resolve(__dirname, 'wwwroot')
    },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: [
                    minicss.loader,
                    'css-loader',
                    {
                        loader: 'postcss-loader',
                        options: {
                            postcssOptions: {
                                plugins: [
                                    autoprefixer
                                ]
                            }
                        }
                    }
                ]
            },
            {
                test: /\.s[ac]ss$/i,
                use: [
                    minicss.loader,
                    'css-loader',
                    {
                        loader: 'postcss-loader',
                        options: {
                            postcssOptions: {
                                plugins: [
                                    autoprefixer
                                ]
                            }
                        }
                    },
                    'sass-loader'
                ]
            }
        ]
    },
    plugins: [
        new remove(),
        new minicss({
            filename: '[name].css'
        })
    ],
    optimization: {
        minimize: true,
        minimizer: [
            new terser({
                terserOptions: {
                    format: {
                        comments: false,
                    },
                },
                extractComments: false,
            })
        ],
    },
    devtool: 'source-map'
}