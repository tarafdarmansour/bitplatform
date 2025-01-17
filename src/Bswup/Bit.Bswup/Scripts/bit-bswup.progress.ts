﻿; (function () {
    (window as any).startBswupProgress = (autoReload: boolean,
        showLogs: boolean,
        showAssets: boolean,
        appContainerSelector: string,
        hideApp: boolean) => {

        var appEl = document.querySelector(appContainerSelector) as HTMLElement;
        var bswupEl = document.getElementById('bit-bswup');
        var progressEl = document.getElementById('bit-bswup-progress-bar');
        var percentEl = document.getElementById('bit-bswup-percent');
        var assetsEl = document.getElementById('bit-bswup-assets');
        var reloadButton = document.getElementById('bit-bswup-reload');
        (window as any).bitBswupHandler = bitBswupHandler;

        function bitBswupHandler(message, data) {
            switch (message) {

                case BswupMessage.updateFound: return showLogs ? console.log('an update found.') : undefined;

                case BswupMessage.stateChanged: return showLogs ? console.log('state has changed to:', data.currentTarget.state) : undefined;

                case BswupMessage.activate: return showLogs ? console.log('new version activated:', data.version) : undefined;

                case BswupMessage.downloadStarted:
                    hideApp && appEl && (appEl.style.display = 'none');
                    bswupEl && (bswupEl.style.display = 'block');
                    return showLogs ? console.log('downloading assets started:', data?.version) : undefined;

                case BswupMessage.downloadProgress:
                    if (showAssets && assetsEl) {
                        const li = document.createElement('li');
                        li.innerHTML = `${data.index}: <b>${data.asset.url}</b>: ${data.asset.hash}`
                        assetsEl.prepend(li);
                    }
                    const percent = Math.round(data.percent);
                    const perStr = `${percent}%`;
                    bswupEl && bswupEl.style.setProperty('--bit-bswup-percent', perStr)
                    bswupEl && bswupEl.style.setProperty('--bit-bswup-percent-text', `"${perStr}"`)
                    progressEl && (progressEl.style.width = `${percent}%`);
                    percentEl && (percentEl.innerHTML = `${percent}%`);
                    return showLogs ? console.log('asset downloaded:', data) : undefined;

                case BswupMessage.downloadFinished:
                    if (autoReload || data.firstInstall) {
                        data.reload().then(() => {
                            hideApp && appEl && (appEl.style.display = 'block');
                            bswupEl && (bswupEl.style.display = 'none');
                        });
                    } else {
                        reloadButton && (reloadButton.style.display = 'block');
                        reloadButton && (reloadButton.onclick = data.reload);
                    }
                    return showLogs ? console.log('downloading assets finished.') : undefined;

                case BswupMessage.updateReady:
                    if (autoReload) {
                        data.reload();
                    } else {
                        reloadButton && (reloadButton.style.display = 'inline');
                        reloadButton && (reloadButton.onclick = data.reload);
                    }
                    return showLogs ? console.log('new update is ready.') : undefined;
            }
        }
    };

}());